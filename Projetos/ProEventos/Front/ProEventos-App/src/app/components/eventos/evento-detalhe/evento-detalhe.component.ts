import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Component, OnInit, TemplateRef } from '@angular/core';
import {
  AbstractControl,
  FormArray,
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Evento } from '@app/models/Evento';
import { EventoService } from '@app/services/evento.service';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { LoteService } from '@app/services/lote.service';
import { Lote } from '@app/models/Lote';

@Component({
  selector: 'app-evento-detalhe',
  templateUrl: './evento-detalhe.component.html',
  styleUrls: ['./evento-detalhe.component.scss'],
})
export class EventoDetalheComponent implements OnInit {
  public modalRef?: BsModalRef;
  protected evento = {} as Evento;
  protected loteAtual = { id: 0, nome: '', indice: 0 };
  protected eventoId: number = 0;
  protected form: FormGroup;
  private _estadoSalvar: string = 'post';

  public get modoEditar(): boolean {
    return this._estadoSalvar === 'put';
  }

  public get formControls(): any {
    return this.form.controls;
  }

  public get bsConfig(): any {
    return {
      isAnimated: true,
      adaptivePosition: true,
      dateInputFormat: 'DD/MM/YYYY H:mm',
      containerClass: 'theme-default',
      showWeekNumbers: false,
    };
  }

  get lotes(): FormArray {
    return this.form.get('lotes') as FormArray;
  }

  constructor(
    private formBuilder: FormBuilder,
    private _localeService: BsLocaleService,
    private _routerActive: ActivatedRoute,
    private _eventoService: EventoService,
    private _loteService: LoteService,
    private _toastr: ToastrService,
    private _spinner: NgxSpinnerService,
    private _router: Router,
    private _modalService: BsModalService
  ) {
    this._localeService.use('pt-br');
  }

  ngOnInit(): void {
    this.validation();
    this.carregarEvento();
  }

  public carregarEvento(): void {
    this.eventoId = +this._routerActive.snapshot.paramMap.get('id');

    if (this.eventoId !== null && this.eventoId !== 0) {
      this._spinner.show();
      this._estadoSalvar = 'put';
      this._eventoService
        .getEventoById(+this.eventoId)
        .subscribe({
          next: (evento: Evento) => {
            this.evento = { ...evento };
            this.form.patchValue(this.evento);
            this._carregarLotes();
          },
          error: () => {
            this._toastr.error('Erro ao carregar Evento', 'Erro!');
          },
        })
        .add(() => this._spinner.hide());
    }
  }

  private _carregarLotes(): void {
    this._loteService
      .getLotesByEventoId(this.eventoId)
      .subscribe({
        next: (lotesRetorno: Lote[]) => {
          lotesRetorno.forEach((lote) => {
            this.lotes.push(this._criarLote(lote));
          });
        },
        error: () =>
          this._toastr.error('Erro ao tentar carregar lotes', 'Erro'),
      })
      .add(() => this._spinner.hide());
  }

  public validation(): void {
    this.form = this.formBuilder.group({
      tema: [
        '',
        [
          Validators.required,
          Validators.minLength(4),
          Validators.maxLength(50),
        ],
      ],
      local: ['', Validators.required],
      dataEvento: ['', [Validators.required]],
      qtdPessoas: ['', [Validators.required, Validators.max(120000)]],
      telefone: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      imageUrl: ['', Validators.required],
      lotes: this.formBuilder.array([]),
    });
  }

  protected cssValidator(campoForm: FormControl | AbstractControl): any {
    return { 'is-invalid': campoForm.errors && campoForm.touched };
  }

  protected salvarEvento(): void {
    this._spinner.show();

    if (this.form.valid) {
      this.evento =
        this._estadoSalvar === 'post'
          ? { ...this.form.value }
          : { id: this.evento.id, ...this.form.value };

      this._eventoService[this._estadoSalvar](this.evento)
        .subscribe({
          next: (eventoRetorno: Evento) => {
            this._toastr.success('Evento salvo.', 'Sucesso');
            this.recarregarEvento(eventoRetorno.id);
          },
          error: () => {
            this._toastr.error('Não foi possível salvar o evento.', 'Erro');
          },
        })
        .add(() => {
          this._spinner.hide();
        });
    }
  }

  protected adicionarLote(): void {
    this.lotes.push(this._criarLote({ id: 0 } as Lote));
  }

  private _criarLote(lote: Lote): FormGroup {
    return this.formBuilder.group({
      id: [lote.id],
      nome: [lote.nome, Validators.required],
      preco: [lote.preco, Validators.required],
      qtd: [lote.qtd, Validators.required],
      dataInicio: [lote.dataInicio],
      dataFim: [lote.dataFim],
    });
  }

  protected salvarLotes(): void {
    if (this.form.controls['lotes'].valid) {
      this._spinner.show();
      this._loteService
        .saveLote(this.eventoId, this.form.value.lotes)
        .subscribe({
          next: () => {
            this._toastr.success('Lotes salvos.', 'Sucesso');
          },
          error: () => {
            this._toastr.error('Não foi possível salvar os lotes.', 'Erro');
          },
        })
        .add(() => this._spinner.hide());
    }
  }

  protected removerLote(template: TemplateRef<any>, indice: number): void {
    this.loteAtual.id = this.lotes.get(indice + '.id').value;
    this.loteAtual.nome = this.lotes.get(indice + '.nome').value;
    this.loteAtual.indice = indice;

    this.modalRef = this._modalService.show(template, { class: 'modal-sm' });
  }

  protected confirmDeleteLote(): void {
    this.modalRef.hide();
    this._spinner.show();

    this._loteService
      .deleteLote(this.eventoId, this.loteAtual.id)
      .subscribe({
        next: () => {
          this._toastr.success('Lote apagado.', 'Sucesso');
          this.lotes.removeAt(this.loteAtual.indice);
        },
        error: () => {
          this._toastr.error(
            `Não foi possível apagar o lote ${this.loteAtual.id}`,
            'Erro'
          );
        },
      })
      .add(() => this._spinner.hide());
  }

  protected declineDeleteLote(): void {
    this.modalRef.hide();
  }

  protected resetForm(): void {
    this.form.reset();
  }

  protected voltarParaEventosLista(): void {
    this._router.navigate([`eventos/lista`]);
  }

  protected recarregarEvento(eventoId: number): void {
    this._router.navigate([`eventos/detalhe/${eventoId}`]);
  }

  protected retornaTituloLote(nomeLote: string): string{
    return nomeLote === null || nomeLote === '' ? 'Nome do lote' : nomeLote;
  }
}

import { Component, OnInit } from '@angular/core';
import {
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

@Component({
  selector: 'app-evento-detalhe',
  templateUrl: './evento-detalhe.component.html',
  styleUrls: ['./evento-detalhe.component.scss'],
})
export class EventoDetalheComponent implements OnInit {
  protected evento = {} as Evento;
  protected form: FormGroup = new FormGroup({});
  private _estadoSalvar: string = 'post';

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

  constructor(
    private formBuilder: FormBuilder,
    private _localeService: BsLocaleService,
    private _router: ActivatedRoute,
    private _eventoService: EventoService,
    private _toastr: ToastrService,
    private _spinner: NgxSpinnerService,
    private _routerBack: Router
  ) {
    this._localeService.use('pt-br');
  }

  ngOnInit(): void {
    this.validation();
    this.carregarEvento();
  }

  public carregarEvento(): void {
    const eventoIdParam = this._router.snapshot.paramMap.get('id');

    if (eventoIdParam !== null) {
      this._spinner.show();
      this._estadoSalvar = 'put';
      this._eventoService
        .getEventoById(+eventoIdParam)
        .subscribe({
          next: (evento: Evento) => {
            this.evento = { ...evento };
            this.form.patchValue(this.evento);
          },
          error: () => {
            this._toastr.error('Erro ao carregar Evento', 'Erro!');
          },
        })
        .add(() => this._spinner.hide());
    }
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
    });
  }

  protected cssValidator(campoForm: FormControl): any {
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
          next: () => this._toastr.success('Evento salvo.', 'Sucesso'),
          error: () => {
            this._toastr.error('Não foi possível salvar o evento.', 'Erro');
          },
        })
        .add(() => {
          this._spinner.hide();
          this.voltarParaEventosLista();
        });
    }
  }

  protected resetForm(): void {
    this.form.reset();
  }

  protected voltarParaEventosLista(): void {
    this._routerBack.navigate([`eventos/lista`]);
  }
}

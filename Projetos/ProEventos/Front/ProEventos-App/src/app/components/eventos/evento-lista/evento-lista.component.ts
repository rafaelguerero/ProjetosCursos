import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Evento } from '@app/models/Evento';
import { EventoService } from '@app/services/evento.service';

@Component({
  selector: 'app-evento-lista',
  templateUrl: './evento-lista.component.html',
  styleUrls: ['./evento-lista.component.scss'],
})
export class EventoListaComponent implements OnInit {
  public modalRef?: BsModalRef;
  public eventos: Evento[] = [];
  public eventosFiltrados: Evento[] = [];
  public larguraImg: number = 150;
  public margemImg: number = 2;
  public ocultarImagem: boolean = true;
  private _filtroLista: string = '';

  public get filtroLista(): string {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.eventosFiltrados = this._filtroLista
      ? this.filtrarEventos(this._filtroLista)
      : this.eventos;
  }

  constructor(
    private EventoService: EventoService,
    private modalService: BsModalService,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService
  ) {}

  public ngOnInit(): void {
    this.spinner.show();
    this.getEventos();
  }

  public alterarImagem(): void {
    this.ocultarImagem = !this.ocultarImagem;
  }

  public getEventos(): void {
    this.EventoService.getEventos().subscribe({
      next: (v: Evento[]) => {
        (this.eventos = v), (this.eventosFiltrados = this.eventos);
      },
      error: (e: any) => {
        this.spinner.hide();
        this.toastr.error('Erro ao carregar Eventos', 'Erro!');
      },
      complete: () => this.spinner.hide(),
    });
  }

  public filtrarEventos(filtrarPor: string): Evento[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (e: { tema: string; local: string }) =>
        e.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
        e.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

  public openModal(template: TemplateRef<any>): void {
    this.modalRef = this.modalService.show(template, { class: 'modal-sm' });
  }

  public confirm(): void {
    this.modalRef?.hide();
    this.toastr.success('Evento excluído com sucesso', 'Excluído!');
  }

  public decline(): void {
    this.modalRef?.hide();
  }
}

import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Evento } from '@app/models/Evento';
import { EventoService } from '@app/services/evento.service';
import { environment } from '@environments/environment';

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
  public eventoId: number = 0;

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
    private spinner: NgxSpinnerService,
    private router: Router
  ) {}

  public ngOnInit(): void {
    this.spinner.show();
    this.carregarEventos();
  }

  public alterarImagem(): void {
    this.ocultarImagem = !this.ocultarImagem;
  }

  public carregarEventos(): void {
    this.EventoService.getEventos().subscribe({
      next: (v: Evento[]) => {
        (this.eventos = v), (this.eventosFiltrados = this.eventos);
      },
      error: (e: any) => {
        this.toastr.error('Erro ao carregar Eventos', 'Erro!');
      }
    }).add(() => this.spinner.hide());
  }

  public filtrarEventos(filtrarPor: string): Evento[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (e: { tema: string; local: string }) =>
        e.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
        e.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

  public openModal(event: any, template: TemplateRef<any>, eventoId: number): void {
    event.stopPropagation();
    this.eventoId = eventoId;
    this.modalRef = this.modalService.show(template, { class: 'modal-sm' });
  }

  public confirmDelete(): void {
    this.modalRef?.hide();
    this.spinner.show();

    this.EventoService.deleteEvento(this.eventoId).subscribe(
      {
        next: () => {
            this.toastr.success(`Evento ${this.eventoId} foi excluído`, 'Excluído!');
            this.carregarEventos()
        },
        error: () => {
          this.toastr.error('Erro ao apagar evento', 'Erro!');
        }
      }
    ).add(() => this.spinner.hide());
  }

  public declineDelete(): void {
    this.modalRef?.hide();
  }

  public detalheEvento(id: number): void {
    this.router.navigate([`eventos/detalhe/${id}`]);
  }

  protected mostrarImagem(imagemUrl: string):string {
    return (imagemUrl !== '')
      ? `${environment.apiUrl}resources/images/${imagemUrl}`
      : 'assets/img/semImagem.jpg';
  }
}

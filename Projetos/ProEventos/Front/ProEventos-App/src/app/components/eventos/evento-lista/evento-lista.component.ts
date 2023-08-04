import { PaginatedResult, Pagination } from './../../../models/Pagination';
import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Evento } from '@app/models/Evento';
import { EventoService } from '@app/services/evento.service';
import { environment } from '@environments/environment';
import { Subject, debounceTime } from 'rxjs';

@Component({
  selector: 'app-evento-lista',
  templateUrl: './evento-lista.component.html',
  styleUrls: ['./evento-lista.component.scss'],
})
export class EventoListaComponent implements OnInit {
  public modalRef?: BsModalRef;
  public eventos: Evento[] = [];
  public larguraImg: number = 150;
  public margemImg: number = 2;
  public ocultarImagem: boolean = true;
  public eventoId: number = 0;
  public pagination = {} as Pagination;

  termoBuscaChanged: Subject<string> = new Subject<string>();

  constructor(
    private eventoService: EventoService,
    private modalService: BsModalService,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService,
    private router: Router
  ) {}

  public ngOnInit(): void {
    this.pagination = {
      currentPage: 1,
      itemsPerPage: 3,
      totalItems: 1,
    } as Pagination;
    this.carregarEventos();
  }

  public alterarImagem(): void {
    this.ocultarImagem = !this.ocultarImagem;
  }

  public carregarEventos(): void {
    this.spinner.show();
    this.eventoService
      .getEventos(this.pagination.currentPage, this.pagination.itemsPerPage)
      .subscribe({
        next: (response: PaginatedResult<Evento[]>) => {
          this.eventos = response.result;
          this.pagination = response.pagination;
        },
        error: (e: any) => {
          this.toastr.error('Erro ao carregar Eventos', 'Erro!');
        },
      })
      .add(() => this.spinner.hide());
  }

  public filtrarEventos(evento: any): void {
    //Causa um delay na digitação para não fazer várias requisições no banco
    if (!this.termoBuscaChanged.observed) {
      this.termoBuscaChanged
        .pipe(debounceTime(1000))
        .subscribe((filtrarPor) => {
          this.spinner.show();
          this.eventoService
            .getEventos(
              this.pagination.currentPage,
              this.pagination.itemsPerPage,
              filtrarPor
            )
            .subscribe({
              next: (response: PaginatedResult<Evento[]>) => {
                this.eventos = response.result;
                this.pagination = response.pagination;
              },
              error: (e: any) => {
                this.toastr.error('Erro ao carregar Eventos', 'Erro!');
              },
            })
            .add(() => this.spinner.hide());
        });
    }
    this.termoBuscaChanged.next(evento.value);
  }

  public openModal(
    event: any,
    template: TemplateRef<any>,
    eventoId: number
  ): void {
    event.stopPropagation();
    this.eventoId = eventoId;
    this.modalRef = this.modalService.show(template, { class: 'modal-sm' });
  }

  public confirmDelete(): void {
    this.modalRef?.hide();
    this.spinner.show();

    this.eventoService
      .deleteEvento(this.eventoId)
      .subscribe({
        next: () => {
          this.toastr.success(
            `Evento ${this.eventoId} foi excluído`,
            'Excluído!'
          );
          this.carregarEventos();
        },
        error: () => {
          this.toastr.error('Erro ao apagar evento', 'Erro!');
        },
      })
      .add(() => this.spinner.hide());
  }

  public declineDelete(): void {
    this.modalRef?.hide();
  }

  public detalheEvento(id: number): void {
    this.router.navigate([`eventos/detalhe/${id}`]);
  }

  protected mostrarImagem(imagemUrl: string): string {
    return imagemUrl !== ''
      ? `${environment.apiUrl}resources/images/${imagemUrl}`
      : 'assets/img/semImagem.jpg';
  }

  protected pageChanged(event): void {
    this.pagination.currentPage = event.page;
    this.carregarEventos();
  }
}

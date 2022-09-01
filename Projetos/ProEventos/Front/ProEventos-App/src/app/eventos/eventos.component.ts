import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';

import { Evento } from '../models/Evento';
import { EventoService } from '../services/evento.service';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
})
export class EventosComponent implements OnInit {
  modalRef?: BsModalRef;
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
    private toastr: ToastrService
  ) {}

  public ngOnInit(): void {
    this.getEventos();
    console.log();
  }

  public alterarImagem(): void {
    this.ocultarImagem = !this.ocultarImagem;
  }

  public getEventos(): void {
    this.EventoService.getEventos().subscribe({
      next: (v: Evento[]) => {
        (this.eventos = v), (this.eventosFiltrados = this.eventos);
      },
      error: (e: any) => console.log(e),
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
    this.toastr.success('Sucesso', 'teste');
  }

  public decline(): void {
    this.modalRef?.hide();
  }
}

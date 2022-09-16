import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-titulos',
  templateUrl: './titulos.component.html',
  styleUrls: ['./titulos.component.scss'],
})
export class TitulosComponent implements OnInit {
  @Input() titulo: string = '';
  @Input() subtitulo: string = 'Desde 2022';
  @Input() iconClass: string = 'fa fa-user';
  @Input() botaoListar: boolean = false;
  constructor() {}

  ngOnInit(): void {}
}

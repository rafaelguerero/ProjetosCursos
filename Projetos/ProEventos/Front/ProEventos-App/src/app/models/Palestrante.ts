import { Evento } from './Evento';
import { RedeSocial } from './RedeSocial';

export interface Palestrante {
  nome: string;
  miniCurriculo: string;
  imagemUrl: string;
  telefone: string;
  email: string;
  redesSociais: RedeSocial[];
  palestrantesEventos: Evento[];
}

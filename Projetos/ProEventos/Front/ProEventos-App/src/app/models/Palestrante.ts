import { Evento } from './Evento';
import { UserUpdate } from './Identity/UserUpdate';
import { RedeSocial } from './RedeSocial';

export interface Palestrante {
  id: number;
  miniCurriculo: string;
  user: UserUpdate;
  redesSociais: RedeSocial[];
  palestrantesEventos: Evento[];
}

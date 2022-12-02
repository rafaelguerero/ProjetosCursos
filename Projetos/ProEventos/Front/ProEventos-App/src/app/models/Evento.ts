import { Lote } from './Lote';
import { Palestrante } from './Palestrante';
import { RedeSocial } from './RedeSocial';

export interface Evento {
  id: number;
  tema: string;
  local: string;
  dataEvento?: Date;
  qtdPessoas: number;
  telefone: string;
  email: string;
  imageUrl: string;
  lotes: Lote[];
  redesSociais: RedeSocial[];
  palestrantesEventos: Palestrante[];
}

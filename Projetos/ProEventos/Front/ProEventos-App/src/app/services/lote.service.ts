import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Lote } from '@app/models/Lote';
import { Observable, take } from 'rxjs';
import { environment } from '@environments/environment';

@Injectable()
export class LoteService {
  private _baseUrl = environment.apiUrl + 'api/lotes';
  constructor(private _http: HttpClient) {}

  public getLotesByEventoId(eventoId: number): Observable<Lote[]> {
    return this._http
      .get<Lote[]>(`${this._baseUrl}/${eventoId}`)
      .pipe(take(1));
  }

  public saveLote(eventoId: number, lotes: Lote): Observable<Lote[]> {
    return this._http
      .put<Lote[]>(`${this._baseUrl}/${eventoId}`, lotes)
      .pipe(take(1));
  }

  public deleteLote(eventoId: number, loteId: number): Observable<any> {
    return this._http
      .delete(`${this._baseUrl}/${eventoId}/${loteId}`)
      .pipe(take(1));
  }
}

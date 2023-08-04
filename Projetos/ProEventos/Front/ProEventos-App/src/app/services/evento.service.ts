import { environment } from '@environments/environment';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map, take } from 'rxjs';
import { Evento } from '../models/Evento';
import { PaginatedResult } from '@app/models/Pagination';

@Injectable()
//{  providedIn: 'root',}
export class EventoService {
  private _baseUrl = environment.apiUrl + 'api/eventos';

  constructor(private http: HttpClient) {}

  public getEventos(
    page?: number,
    itemsPerPage?: number,
    term?: string
  ): Observable<PaginatedResult<Evento[]>> {
    const paginatedResult: PaginatedResult<Evento[]> = new PaginatedResult<
      Evento[]
    >();

    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('pageNumber', page.toString());
      params = params.append('pageSize', itemsPerPage.toString());
    }

    if (term != null && term != '') params = params.append('term', term);

    return this.http
      .get<Evento[]>(this._baseUrl, { observe: 'response', params })
      .pipe(
        take(1),
        map((response) => {
          paginatedResult.result = response.body;
          if (response.headers.has('Pagination')) {
            paginatedResult.pagination = JSON.parse(
              response.headers.get('Pagination')
            );
          }
          return paginatedResult;
        })
      );
  }

  public getEventoById(id: number): Observable<Evento> {
    return this.http.get<Evento>(`${this._baseUrl}/${id}`).pipe(take(1));
  }

  public post(evento: Evento): Observable<Evento> {
    return this.http.post<Evento>(this._baseUrl, evento).pipe(take(1));
  }

  public put(evento: Evento): Observable<Evento> {
    return this.http
      .put<Evento>(`${this._baseUrl}/${evento.id}`, evento)
      .pipe(take(1));
  }

  public deleteEvento(id: number): Observable<Evento> {
    return this.http.delete<Evento>(`${this._baseUrl}/${id}`).pipe(take(1));
  }

  public postUploadImage(eventoId: number, file: File): Observable<Evento> {
    const fileToUpload = file[0] as File;
    const formData = new FormData();
    formData.append('file', fileToUpload);

    return this.http
      .post<Evento>(`${this._baseUrl}/upload-image/${eventoId}`, formData)
      .pipe(take(1));
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Jeux } from '../models/jeux';

@Injectable({
  providedIn: 'root'
})
export class JeuxService {

  constructor(private http: HttpClient) { }

  getDebutJeu(): Observable<Jeux>{
    return this.http.get<Jeux>("https://localhost:44303/DebutPartie");
  }
}

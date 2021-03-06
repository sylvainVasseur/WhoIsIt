import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Personnages } from '../models/personnages.model';

@Injectable({
  providedIn: 'root'
})
export class PersonnageService {

  constructor(private http: HttpClient) { }

  getPersonnages() : Observable<Personnages[]>{
    return this.http.get<Personnages[]>("https://localhost:44303/allPersonnages");
  }
  getPersonnagesByID(id: string) : Observable<Personnages>{
    return this.http.get<Personnages>(`https://localhost:44303/Personnageid/${id}`);
  }
}

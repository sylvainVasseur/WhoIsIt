import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ListeQuestionsReponses } from '../models/liste-questions-reponses.model';

@Injectable({
  providedIn: 'root'
})
export class ListeQuestionsReponsesService {

  constructor(private http: HttpClient) { }
  getListeQuestionsReponses() : Observable<ListeQuestionsReponses[]>{
    return this.http.get<ListeQuestionsReponses[]>("https://localhost:44303/allQuestionReponses");
  }
}

import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ListeQuestionsReponses } from 'src/app/models/liste-questions-reponses.model';
import { Personnages } from 'src/app/models/personnages.model';
import { ListeQuestionsReponsesService } from 'src/app/services/liste-questions-reponses.service';
import { PersonnageService } from 'src/app/services/personnage.service';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {

  listPersonnage : Array<Personnages> = [];
  listQuestion :  Array<ListeQuestionsReponses> = [];
  nbQuestion : number = 0;
  NumeroPersonnageAI!: number;

  constructor(private http: HttpClient, private router: Router, private service: PersonnageService, private serviceListeQuestions: ListeQuestionsReponsesService) { }

  ngOnInit(): void {

    this.service.getPersonnages().subscribe(data =>{
      this.listPersonnage = data;
      console.log(this.listPersonnage[0]);
    });
    console.log("numero personnage : " + this.NumeroPersonnageAI);

    this.serviceListeQuestions.getListeQuestionsReponses().subscribe(data =>{
      this.listQuestion = data;
    })
  }

}

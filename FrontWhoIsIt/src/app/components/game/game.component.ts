import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ListeQuestionsReponses } from 'src/app/models/liste-questions-reponses.model';
import { Personnages } from 'src/app/models/personnages.model';
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

  constructor(private http: HttpClient, private router: Router, private service: PersonnageService,) { }

  ngOnInit(): void {
  }

}

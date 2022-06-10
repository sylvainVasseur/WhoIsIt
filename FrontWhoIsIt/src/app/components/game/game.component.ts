import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Jeux } from 'src/app/models/jeux';
import { ListeQuestionsReponses } from 'src/app/models/liste-questions-reponses.model';
import { Personnages } from 'src/app/models/personnages.model';
import { ListeQuestionsReponsesDTO } from 'src/app/models/questionsReponsesDTO';
import { JeuxService } from 'src/app/services/jeux.service';
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
  jeux: Jeux = new Jeux;
  selectedPersonnageID: string = "";
  gagner: boolean = false;
  questionsReponses: Array<ListeQuestionsReponsesDTO> = [];
  personneAEliminer: String[] = [];
  data: any;

  constructor(
    private http: HttpClient, 
    private router: Router, 
    private service: PersonnageService, 
    private serviceListeQuestions: ListeQuestionsReponsesService,
    private serviceJeux: JeuxService
    ) { }

  ngOnInit(): void {

    this.service.getPersonnages().subscribe(data =>{
      this.listPersonnage = data;
      console.log(this.listPersonnage[0]);
    });
    console.log("numero personnage : " + this.NumeroPersonnageAI);

    this.serviceListeQuestions.getListeQuestionsReponses().subscribe(data =>{
      this.listQuestion = data;
    })

    this.serviceJeux.getDebutJeu().subscribe(data => {
      this.selectedPersonnageID = data.selectedPersoId;
      this.jeux = data;
      this.questionsReponses = data.questionsReponses;
      
    })
  }

  selectedPersonnage = (id: string) => {
    
    if(id == this.selectedPersonnageID){
      this.gagner = true
    }else{
      this.gagner = false;

      alert("Mauvais choix");
    }
  }

  selectedQuestion = (id: string) => {
    this.listQuestion.forEach(q => {
      if(id == q.id){
        alert(q.reponse);
        q.asked = true;
        
      }
    });

    this.questionsReponses.forEach(qR => {
      if(qR.id == id){
        this.personneAEliminer = qR.personnagesIdAEliminer;
      }
    })

    this.listPersonnage.forEach(p => {
      this.personneAEliminer.forEach(y => {
        if(p.id == y){
          p.urlPhoto = "../../assets/img/logo1.png";
        }
      })
    })

    console.log(this.listPersonnage);
    
  }

}

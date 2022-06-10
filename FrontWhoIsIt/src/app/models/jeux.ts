import { ListeQuestionsReponses } from "./liste-questions-reponses.model";

export class Jeux{
    idSelectedPersonnage: string;
    questionsReponses: ListeQuestionsReponses[];

    constructor(){
        this.idSelectedPersonnage = "";
        this.questionsReponses = [];
    }
}
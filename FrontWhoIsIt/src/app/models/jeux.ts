
import { ListeQuestionsReponsesDTO } from "./questionsReponsesDTO";

export class Jeux{
    selectedPersoId: string;
    questionsReponses: ListeQuestionsReponsesDTO[];


    constructor(){
        this.selectedPersoId = "";
        this.questionsReponses = [];
    }
}
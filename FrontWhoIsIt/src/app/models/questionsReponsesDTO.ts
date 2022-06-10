export class ListeQuestionsReponsesDTO {

    id: string;
    question: string;
    reponse: boolean;
    asked: boolean;
    personnagesIdAEliminer: string[];

    constructor(){
        this.id ="";
        this.question = "";
        this.reponse = false;
        this.asked = false;
        this.personnagesIdAEliminer = [];
    }


}

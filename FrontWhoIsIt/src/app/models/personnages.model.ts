export class Personnages {

    id: string;
    genre: string;
    prenom: string;
    espece: string;
    couleurYeux: string;
    couleurCheveux: string;
    hasLunette: boolean;
    hasChapeau: boolean;
    isWizard: boolean;
    visible: boolean;
    urlPhoto: string;

    constructor(){
        this.id = "";
        this.genre = "";
        this.prenom ="";
        this.espece = "";
        this.couleurYeux = "";
        this.couleurCheveux = "";
        this.hasLunette = false;
        this.hasChapeau = false;
        this.isWizard = false;
        this.visible = true;
        this.urlPhoto ="";
    }
}

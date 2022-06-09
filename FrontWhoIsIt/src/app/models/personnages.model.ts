export class Personnages {

    id: string;
    genre: string;
    espece: string;
    couleuryeux: string;
    couleurcheveux: string;
    haslunette: boolean;
    hasChapeau: boolean;
    iswizard: boolean;
    urlphoto: string;

    constructor(){
        this.id = "";
        this.genre = "";
        this.espece = "";
        this.couleuryeux = "";
        this.couleurcheveux = "";
        this.haslunette = false;
        this.hasChapeau = false;
        this.iswizard = false;
        this.urlphoto ="";
    }
}

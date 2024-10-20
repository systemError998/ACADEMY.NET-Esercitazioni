import { Injectable } from "@angular/core";
import { Destinazione } from "../models/destinazione";
import { urlDestinazioni } from "../config/url";

//prvidedIN indica che l'iniezione è disponibile a libello globale
@Injectable({
    providedIn: 'root'
})

export class DestinazioneRepo{

    private elencoDestinazioni: Destinazione[] = [];

    constructor() {}

    GetAll(): Destinazione[] {

        fetch(urlDestinazioni, {
            headers: {
                'Content-Type': 'application/json'
            }
        })
        .then(response => response.json())
         .then(arrayDestinazioni => {
            arrayDestinazioni.forEach((element: Destinazione) => {
                this.elencoDestinazioni.push(element);
                // console.log(element);
            });
            
        })
        .catch(error => {
            console.error("Errore nel fetch:", error);
        });
    
        return this.elencoDestinazioni;
        //TODO: METTI TUTTO IN ELENCO DESTINAZIONI E NGFOR STAMPA TUTTO
    }
    

    
}
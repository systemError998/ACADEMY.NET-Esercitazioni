import { Injectable } from "@angular/core";
import { urlRecensioni } from "../config/url";
import { Recensione } from "../models/recensione";

//prvidedIN indica che l'iniezione è disponibile a libello globale
@Injectable({
    providedIn: 'root'
})

export class RecensioneRepo{

    private elencoRecensioni: Recensione[] = [];

    constructor() {}

    GetAll() : Recensione[]{

        fetch(urlRecensioni, {
            headers: {
                'Content-Type': 'application/json'
            }
        })
        .then(response => response.json())
            .then(arrayRecensioni => {
                arrayRecensioni.forEach((recens : Recensione)=> {
                    this.elencoRecensioni.push(recens)
                });
            })
        .catch(error => {
            console.error("Errore nel fetch:", error);
        });

        return this.elencoRecensioni;

    }

}
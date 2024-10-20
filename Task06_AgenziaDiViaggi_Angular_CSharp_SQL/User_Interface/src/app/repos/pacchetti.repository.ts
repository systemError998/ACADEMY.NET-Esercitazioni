import { Injectable } from "@angular/core";

import { urlPacchetti } from "../config/url";
import { Pacchetto } from "../models/pacchetto";

@Injectable({
    providedIn: 'root'
})

export class PacchettoRepo{

    private elencoPacchetti: Pacchetto[] = []

    constructor() {}

    GetAll(): Pacchetto[] {

        fetch(urlPacchetti)
        .then(response => response.json())
        .then(arrayPacchetty => {
            arrayPacchetty.forEach((pacco: Pacchetto) => {
                this.elencoPacchetti.push(pacco)
            });
        })

        return this.elencoPacchetti;
        
    }
}
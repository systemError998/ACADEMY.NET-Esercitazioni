import { Injectable } from '@angular/core';
import { DestinazioneRepo } from '../repos/destinazione.repository';
import { Recensione } from '../models/recensione';
import { RecensioneRepo } from '../repos/recensione.repository';

@Injectable({
  providedIn: 'root'
})
export class RecensioneService {

  constructor(private repo : RecensioneRepo) { }

  ListaRecensioni() : Recensione[]{
    return this.repo.GetAll();
  }

}

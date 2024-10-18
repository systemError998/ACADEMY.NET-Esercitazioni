import { Injectable } from '@angular/core';
import { DestinazioneRepo } from '../repos/destinazione.repository';
import { Destinazione } from '../models/destinazione';

@Injectable({
  providedIn: 'root'
})

export class DestinazioneService {

  //inietto la dipendenza della repo, perchè il mio service dipende dalla repo
  constructor(private repo: DestinazioneRepo) { }

  ListaDestinazioni(): Destinazione[]{
    return this.repo.GetAll();
  }
  
}

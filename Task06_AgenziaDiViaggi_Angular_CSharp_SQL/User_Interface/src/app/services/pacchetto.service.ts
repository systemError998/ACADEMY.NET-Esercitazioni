import { Injectable } from '@angular/core';
import { PacchettoRepo } from '../repos/pacchetti.repository';
import { Pacchetto } from '../models/pacchetto';

@Injectable({
  providedIn: 'root'
})
export class PacchettoService {

  constructor(private repo: PacchettoRepo) { }

  ListaPacchetti(): Pacchetto[]{
    return this.repo.GetAll();
  }

}

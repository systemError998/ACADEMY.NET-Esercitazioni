import { Component } from '@angular/core';
import { PacchettoService } from '../../services/pacchetto.service';
import { Pacchetto } from '../../models/pacchetto';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-pacchetti',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './pacchetti.component.html',
  styleUrl: './pacchetti.component.css'
})
export class PacchettiComponent {

  constructor(private service: PacchettoService){}

  elencoPacchetti: Pacchetto[] = [];

  ngOnInit(){
    this.elencoPacchetti = this.service.ListaPacchetti();
  }

}

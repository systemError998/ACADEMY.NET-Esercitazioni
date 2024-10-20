import { Component } from '@angular/core';
import { DestinazioneService } from '../../services/destinazione.service';
import { Destinazione } from '../../models/destinazione';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-lista-destinazioni',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './lista-destinazioni.component.html',
  styleUrl: './lista-destinazioni.component.css'
})

export class ListaDestinazioniComponent {

  constructor(private service: DestinazioneService){}

  elencoDestinazioni: Destinazione[] = [];

  ngOnInit(){
    this.elencoDestinazioni = this.service.ListaDestinazioni();
  }


}

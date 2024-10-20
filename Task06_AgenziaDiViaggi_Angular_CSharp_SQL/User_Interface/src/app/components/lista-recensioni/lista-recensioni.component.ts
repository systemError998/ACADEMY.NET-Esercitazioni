import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RecensioneService } from '../../services/recensione.service';
import { Recensione } from '../../models/recensione';

@Component({
  selector: 'app-lista-recensioni',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './lista-recensioni.component.html',
  styleUrl: './lista-recensioni.component.css'
})
export class ListaRecensioniComponent {

  constructor(private service : RecensioneService) {}

  elencoRecensioni: Recensione[] = [];

  ngOnInit(){
    this.elencoRecensioni = this.service.ListaRecensioni();
  }

}

import { Routes } from '@angular/router';
import { ListaDestinazioniComponent } from './components/lista-destinazioni/lista-destinazioni.component';
import { HomeComponent } from './components/home/home.component';
import { PacchettiComponent } from './components/pacchetti/pacchetti.component';
import { RecensioniComponent } from './components/recensioni/recensioni.component';

export const routes: Routes = [
    {path: "", redirectTo: "home", pathMatch: "full"},
    {path: "home", component: HomeComponent},
    {path: "destinazioni", component: ListaDestinazioniComponent},
    {path: "pacchetti", component: PacchettiComponent},
    {path: "recensioni", component: RecensioniComponent}
];

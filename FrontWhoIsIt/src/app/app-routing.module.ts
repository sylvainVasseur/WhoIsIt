import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccueilComponent } from './components/accueil/accueil.component';
import { GameComponent } from './components/game/game.component';
import { ReglesComponent } from './components/regles/regles.component';

const routes: Routes = [
  { path: "", component: AccueilComponent },
  { path: "regles", component: ReglesComponent },
  { path: "game", component: GameComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

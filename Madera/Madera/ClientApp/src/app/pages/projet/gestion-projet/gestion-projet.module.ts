import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'; 
import { IonicModule } from '@ionic/angular';
import { HttpClientModule, HttpClient } from '@angular/common/http';  

import { GestionProjetPageRoutingModule } from './gestion-projet-routing.module';
import { ProjetWebService } from './../../../webServices/projet-webservice.service';
import { DevisService } from './../../../WebServices/devis-webservice.service';
import { PlanService } from './../../../WebServices/plan-webservice.service';
import { GestionProjetPage } from './gestion-projet.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    IonicModule,
    HttpClientModule,
    GestionProjetPageRoutingModule,
  ],
  declarations: [GestionProjetPage],
  providers: [ProjetWebService,DevisService,PlanService]
})
export class GestionProjetPageModule {}

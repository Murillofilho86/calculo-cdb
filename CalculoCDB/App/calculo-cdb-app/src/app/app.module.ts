import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { InvestimentoService } from './shared/services/investimento.service';
import { AlertaService } from './shared/services/alerta.service';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
  ],
  providers: [
    InvestimentoService,
    AlertaService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Simulacao } from "../models/Simulacao";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";

@Injectable({
    providedIn: 'root'
  })
  export class InvestimentoService {
  
    protected baseUrl: string = `${environment.apiUrl}`;
  
    constructor(private httpClient: HttpClient)  {}
  
    calcular(data: Simulacao) : Observable<any> {
      return this.httpClient.get<any>(`${this.baseUrl}CDB?ValorInicial=${data.valor}&Prazo=${data.prazo}`);
    }
  
  }

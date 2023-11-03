import Swal, { SweetAlertResult } from 'sweetalert2';
import { Injectable } from '@angular/core';
import { AlertType } from '../enums/enum-alerttype';

const swalWithBootstrapButtons = Swal.mixin({
  customClass: {
    confirmButton: 'btn btn-success',
    cancelButton: 'btn btn-danger'
  },
  buttonsStyling: false
})


@Injectable()
export class AlertaService{

  constructor() {}
  
  
  emiteAlertaSimples(tipo:AlertType,titulo:string,mensagem:string){
    return Swal.fire({
      title:titulo,
      text:mensagem,
      icon:tipo,
    })
  }

  emiteAlertaSimplesHtml(tipo:AlertType,tituloHtml:string,mensagemHtml:string){
    Swal.fire({
      title: tituloHtml,
      icon: tipo,
      html:mensagemHtml
    })
  }

  emiteAlertaPerguntaSimples(tipo:AlertType,titulo:string,mensagem:string) : Promise<SweetAlertResult>{
   return swalWithBootstrapButtons.fire({
      title:titulo,
      text:mensagem,
      icon:tipo,
      showCancelButton: true,
      cancelButtonText: 'cancelar',
      confirmButtonText: 'confirmar'
    })
  }

  emiteAlertaLoading(tipo:AlertType,titulo:string,mensagem:string) :  Promise<SweetAlertResult<any>>{
    return swalWithBootstrapButtons.fire({
       title:titulo,
       text:mensagem,
       allowOutsideClick:false,
       allowEscapeKey:false,
       icon:tipo,
       didOpen: () => {
        Swal.showLoading() 
      }
     })
   }

   fecharAlerta(){
    Swal.close();
   }
}
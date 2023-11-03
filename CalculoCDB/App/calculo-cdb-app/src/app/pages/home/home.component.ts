import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InvestimentoService } from 'src/app/shared/services/investimento.service';
import { Simulacao } from '../../shared/models/Simulacao';
import { AlertaService } from 'src/app/shared/services/alerta.service';
import { AlertType } from 'src/app/shared/enums/enum-alerttype';
import { Resultado } from 'src/app/shared/models/Resultado';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {
  
  resultado: Resultado = new Resultado(0, 0);
  public form: FormGroup = this.formBuilder.group({
    valor: ['', [Validators.required, Validators.min(1)]],
    prazo: ['', [Validators.required, Validators.min(1)]],
  })


  constructor(
    private formBuilder: FormBuilder,
    private service: InvestimentoService,
    private alertaService: AlertaService) { }



  onSubmit() {
    if (this.form.valid) {
      const data = this.form.value;
      const simulacao = new Simulacao(
        data.valor, data.prazo
      )


      this.service.calcular(simulacao).subscribe(
        (res) => {
          // this.alertaService.emiteAlertaLoading(
          //   AlertType.Info,
          //   'Carregando...',
          //   ''
          // );

          this.resultado = new Resultado(res.result.valorBruto, res.result.valorLiquido);
          this.form.reset();
        }, (ex) => {
          this.alertaService.emiteAlertaSimples(
            AlertType.Error,
            'Erro',
            ex.error.message
          );
        }
      );
    }
  }
}

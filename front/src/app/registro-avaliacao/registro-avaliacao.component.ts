import { Component, OnInit } from '@angular/core';
import { Cliente } from '../models/cliente.model';
import { Avaliacao } from '../models/avaliacao.model';
import { ClienteService } from '../services/cliente.service';
import { AvaliacaoService } from '../services/avaliacao.service';

@Component({
  selector: 'app-registro-avaliacao',
  templateUrl: './registro-avaliacao.component.html'
})
export class RegistroAvaliacaoComponent implements OnInit {

  avaliacao: Avaliacao = new Avaliacao();
  clientes: Cliente[] = [];

  constructor(private clienteService: ClienteService, private avaliacaoService: AvaliacaoService) {}

  ngOnInit() {
    this.clientes = this.clienteService.getClientes();
  }

  onSubmit() {
    this.avaliacaoService.addAvaliacao(this.avaliacao);
  }
}
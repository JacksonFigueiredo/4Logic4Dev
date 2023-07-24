import { Component } from '@angular/core';
import { Cliente } from '../models/cliente.model';
import { ClienteService } from '../services/cliente.service';

@Component({
  selector: 'app-cadastro-cliente',
  templateUrl: './cadastro-cliente.component.html'
})
export class CadastroClienteComponent {
  
  cliente: Cliente = new Cliente();

  constructor(private clienteService: ClienteService) {}

  onSubmit() {
    // Aqui você também deveria adicionar lógicas para verificar se o CNPJ já existe
    this.clienteService.addCliente(this.cliente);
  }
}
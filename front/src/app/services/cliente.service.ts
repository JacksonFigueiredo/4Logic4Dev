import { Injectable } from '@angular/core';
import { Cliente } from '../models/cliente.model';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  private clientes: Cliente[] = [];

  addCliente(cliente: Cliente) {
    this.clientes.push(cliente);
  }

  getClientes() {
    return this.clientes;
  }
}
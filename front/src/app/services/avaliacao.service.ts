import { Injectable } from '@angular/core';
import { Avaliacao } from '../models/avaliacao.model';

@Injectable({
  providedIn: 'root'
})
export class AvaliacaoService {

  private avaliacoes: Avaliacao[] = [];

  addAvaliacao(avaliacao: Avaliacao) {
    this.avaliacoes.push(avaliacao);
  }

  getAvaliacoes() {
    return this.avaliacoes;
  }
}
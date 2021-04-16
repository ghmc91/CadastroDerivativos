import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';

import { EquityOpt } from './equity-opt';

@Component({
  selector: 'app-equity-opt',
  templateUrl: './equity-opt.component.html',
  styleUrls: ['./equity-opt.component.css']
})
export class EquityOptComponent {
  public displayedColumns: string[] = ['Ticker', 'Instrument', 'Strike', 'Market',
                                       'Payout', 'Style', 'MaturityLabel']
  public cities: MatTableDataSource<EquityOpt>;
  constructor() { }
}

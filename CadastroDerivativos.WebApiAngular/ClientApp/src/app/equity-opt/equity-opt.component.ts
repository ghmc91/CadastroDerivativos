import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
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
  public equitiesOpts: MatTableDataSource<EquityOpt>;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) { }

    ngOnInit(){
      this.getData(); 
    }

    getData(){
      var url = this.baseUrl + 'api/equityopt';
      this.http.get<any>(url)
        .subscribe(result => {
          this.equitiesOpts = new MatTableDataSource<EquityOpt>(result.data);
        }, error => console.error(error));
    }
}

import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit, ViewChild} from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

import { EquityOpt } from './equityopt';

@Component({
  selector: 'app-equityopt',
  templateUrl: './equityopt.component.html',
  styleUrls: ['./equityopt.component.css']
})
export class EquityoptComponent implements OnInit {

  public displayedColumns: string[] = ['Ticker', 'Instrument', 'Strike', 'Market',
                                       'Payout', 'Style', 'MaturityLabel']
  public equitiesOpts: MatTableDataSource<EquityOpt>;

    constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) { }
  
  ngOnInit() {
    this.getData()
  }

  getData(){
    this.http.get<any>(this.baseUrl + 'api/equityopt')
      .subscribe(result => {
        this.equitiesOpts = new MatTableDataSource<EquityOpt>(result);
        console.log(this.equitiesOpts);
      }, error => console.error(error));
 }

  }

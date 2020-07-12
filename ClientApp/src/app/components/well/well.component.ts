import { Component, OnInit, Inject } from '@angular/core';
import { Iwell } from '../../interfaces/iwell';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-well',
  templateUrl: './well.component.html',
  styleUrls: ['./well.component.css']
})
export class WellComponent implements OnInit {

  public wells: Iwell[];
  public dNumber: number;
  public eNumber: number;
  public latNumber: number;
  public longNumber: number;

  public newWell: Iwell = { districtNumber: this.dNumber, elevation: this.eNumber, latitude: this.latNumber, longitude: this.longNumber };

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  async ngOnInit() {
    this.wells = await this.http.get<Iwell[]>(this.baseUrl + 'well').toPromise();
  }

  async addWell() {
    await this.http.post<Iwell>(this.baseUrl + 'well', this.newWell).toPromise();
    this.newWell = { districtNumber: this.dNumber, elevation: this.eNumber, latitude: this.latNumber, longitude: this.longNumber };
    this.wells = await this.http.get<Iwell[]>(this.baseUrl + 'well').toPromise();
  }

  async deleteWell(x) {
    await this.http.delete<Iwell>(this.baseUrl + 'well' + '/' + x.id).toPromise();
    console.log('Delete called');
    this.wells = await this.http.get<Iwell[]>(this.baseUrl + 'well').toPromise();
  }
}

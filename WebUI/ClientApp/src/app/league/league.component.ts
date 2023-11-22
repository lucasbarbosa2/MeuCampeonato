import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'league',
  templateUrl: './league.component.html'
})
export class LeagueComponent {
  public leagues: League[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<League[]>(baseUrl + 'api/leagues').subscribe(result => {
      this.leagues = result;
    }, error => console.error(error));
  }
}

interface League{
  id: number;
  leagueName: string;
}

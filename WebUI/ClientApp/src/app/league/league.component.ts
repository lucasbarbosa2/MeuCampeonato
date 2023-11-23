import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router, NavigationExtras } from "@angular/router";

@Component({
  selector: 'league',
  templateUrl: './league.component.html'
})
export class LeagueComponent {
  public leagues: League[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router) {
    http.get<League[]>(baseUrl + 'api/leagues').subscribe(result => {
      this.leagues = result;
    }, error => console.error(error));
  }

  play($myParam: number): void {
    let navigationExtras: NavigationExtras = {
      queryParams: {
        "leagueId": $myParam        
      }
    };
    this.router.navigate(["match"], navigationExtras);
  }
}

interface League{
  id: number;
  name: string;
}

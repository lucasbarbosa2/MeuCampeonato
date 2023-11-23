import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'match',
  templateUrl: './match.component.html'
})
export class MatchComponent {
  public matches: Matches = {} as Matches;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: ActivatedRoute) {
    http.get<Matches>(baseUrl + 'api/matches?leagueId=' + this.router.snapshot.queryParams['leagueId']).subscribe(result => {
      this.matches = result;
    }, error => console.error(error));
  }

  get quarterMatches() {
    return this.matches?.matches?.filter(f => f.isQuarter);
  }
  get semiMatches() {
    return this.matches?.matches?.filter(f => f.isSemi);
  }
  get finalMatch() {
    return this.matches?.matches?.filter(f => f.isFinal);
  }
  get thirdMatch() {
    return this.matches?.matches?.filter(f => f.isThird);
  }
}
interface Matches {
  leagueName: string;
  matches: Match[]
}
interface Match {
  id: number;
  teamOne: number;
  teamTwo: number;
  teamOneScore: number;
  teamTwoScore: number;
  teamOneName: string;
  teamTwoName: string;
  isQuarter: boolean;
  isSemi: boolean;
  isFinal: boolean;
  isThird: boolean;
}

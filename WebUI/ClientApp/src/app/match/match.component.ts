import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'match',
  templateUrl: './match.component.html'
})
export class MatchComponent {
  public matches: Match[] = [];
  public teams: Team[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: ActivatedRoute) {
    http.get<Match[]>(baseUrl + 'api/matches?leagueId=' + this.router.snapshot.queryParams['leagueId']).subscribe(result => {
      this.matches = result;
    }, error => console.error(error));
    http.get<Team[]>(baseUrl + 'api/teams?leagueId=' + this.router.snapshot.queryParams['leagueId']).subscribe(result => {
      this.teams = result;
      this.matches = this.matches.map(e => {
        return {
          id: e.id,
          teamOne: e.teamOne,
          teamTwo: e.teamTwo,
          teamOneScore: e.teamOneScore,
          teamTwoScore: e.teamTwoScore,
          teamOneName: this.teams.find(i => i.id === e.teamOne)?.name ?? '',
          teamTwoName: this.teams.find(f => f.id === e.teamTwo)?.name ?? '',
        }
      })
    }, error => console.error(error));

    
  }
}

interface Match {
  id: number;
  teamOne: number;
  teamTwo: number;
  teamOneScore: number;
  teamTwoScore: number;
  teamOneName: string;
  teamTwoName: string;
}

interface Team {
  id: number;
  name: string;
}

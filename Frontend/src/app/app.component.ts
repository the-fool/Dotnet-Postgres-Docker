import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface Gadget {
  id: number;
  name: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  gadgets: string[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get<Gadget[]>('http://localhost:5000/api/gadgets')
      .subscribe(gs => {
        this.gadgets = gs.map(g => g.name);
      });
  }
}

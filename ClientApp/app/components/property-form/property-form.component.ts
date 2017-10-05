import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-property-form',
  templateUrl: './property-form.component.html',
  styleUrls: ['./property-form.component.css']
})
export class PropertyFormComponent implements OnInit {

  property: any = {

  };

  constructor(private _httpService: Http) { }

  properties: string[] = [];
  ngOnInit() {
    this._httpService.get("/api/properties").subscribe(properties => {
      this.properties = properties.json() as string[];
    })
  }

}

import { Property } from './../models/property';
import { Injectable } from '@angular/core';
import { Http } from '@angular/http'; 
import 'rxjs/add/operator/map';

@Injectable()
export class PropertyService {
    private readonly propertiesEndpoint = "/api/properties";

    constructor(private http: Http) { }

    // create(property) {
    //     return this.http.post(this.propertiesEndpoint, property)
    //         .map(res => res.json());
    // }

    // getProperty(id) {
    //     return this.http.get(this.propertiesEndpoint + '/' + id)
    //         .map(res => res.json());
    // }
}
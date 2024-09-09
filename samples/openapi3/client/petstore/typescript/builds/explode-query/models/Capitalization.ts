/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { HttpFile } from '../http/http';

export class Capitalization {
    'smallCamel'?: string;
    'capitalCamel'?: string;
    'smallSnake'?: string;
    'capitalSnake'?: string;
    'sCAETHFlowPoints'?: string;
    /**
    * Name of the pet

    */
    'ATT_NAME'?: string;

    static readonly discriminator: string | undefined = undefined;

    static readonly mapping: {[index: string]: string} | undefined = undefined;

    static readonly attributeTypeMap: Array<{name: string, baseName: string, type: string, format: string}> = [
        {
            "name": "smallCamel",
            "baseName": "smallCamel",
            "type": "string",
            "format": ""
        },
        {
            "name": "capitalCamel",
            "baseName": "CapitalCamel",
            "type": "string",
            "format": ""
        },
        {
            "name": "smallSnake",
            "baseName": "small_Snake",
            "type": "string",
            "format": ""
        },
        {
            "name": "capitalSnake",
            "baseName": "Capital_Snake",
            "type": "string",
            "format": ""
        },
        {
            "name": "sCAETHFlowPoints",
            "baseName": "SCA_ETH_Flow_Points",
            "type": "string",
            "format": ""
        },
        {
            "name": "ATT_NAME",
            "baseName": "ATT_NAME",
            "type": "string",
            "format": ""
        }    ];

    static getAttributeTypeMap() {
        return Capitalization.attributeTypeMap;
    }

    public constructor() {
    }
}

/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { HeroResponse } from '../models/HeroResponse';

import type { CancelablePromise } from '../core/CancelablePromise';
import { OpenAPI } from '../core/OpenAPI';
import { request as __request } from '../core/request';

export class HeroService {

    /**
     * @returns HeroResponse Success
     * @throws ApiError
     */
    public static getApiHero(): CancelablePromise<Array<HeroResponse>> {
        return __request(OpenAPI, {
            method: 'GET',
            url: '/api/hero',
        });
    }

}

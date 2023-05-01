/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { MatchPrediction } from '../models/MatchPrediction';
import type { PredictionRequest } from '../models/PredictionRequest';

import type { CancelablePromise } from '../core/CancelablePromise';
import { OpenAPI } from '../core/OpenAPI';
import { request as __request } from '../core/request';

export class PredictorService {

    /**
     * @param requestBody
     * @returns MatchPrediction Success
     * @throws ApiError
     */
    public static postApiPredictor(
        requestBody?: PredictionRequest,
    ): CancelablePromise<Array<MatchPrediction>> {
        return __request(OpenAPI, {
            method: 'POST',
            url: '/api/predictor',
            body: requestBody,
            mediaType: 'application/json',
        });
    }

}

/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
export { ApiError } from './core/ApiError';
export { CancelablePromise, CancelError } from './core/CancelablePromise';
export { OpenAPI } from './core/OpenAPI';
export type { OpenAPIConfig } from './core/OpenAPI';

export type { HeroResponse } from './models/HeroResponse';
export type { MatchPrediction } from './models/MatchPrediction';
export type { PredictionRequest } from './models/PredictionRequest';

export { HeroService } from './services/HeroService';
export { PredictorService } from './services/PredictorService';

//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

/* tslint:disable */
/* eslint-disable */
// ReSharper disable InconsistentNaming

export class OpayoClient {
    private http: { fetch(url: RequestInfo, init?: RequestInit): Promise<Response> };
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(baseUrl?: string, http?: { fetch(url: RequestInfo, init?: RequestInit): Promise<Response> }) {
        this.http = http ? http : window as any;
        this.baseUrl = baseUrl !== undefined && baseUrl !== null ? baseUrl : "https://localhost:6001";
    }

    completeThreeDSecureChallenge(flowId: string, cRes: string | null | undefined, threeDsSessionData: string | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/umbraco/api/Opayo/payments/{flowId}/completeThreeDSecureChallenge";
        if (flowId === undefined || flowId === null)
            throw new Error("The parameter 'flowId' must be defined.");
        url_ = url_.replace("{flowId}", encodeURIComponent("" + flowId));
        url_ = url_.replace(/[?&]$/, "");

        const content_ = new FormData();
        if (cRes !== null && cRes !== undefined)
            content_.append("CRes", cRes.toString());
        if (threeDsSessionData !== null && threeDsSessionData !== undefined)
            content_.append("ThreeDsSessionData", threeDsSessionData.toString());

        let options_: RequestInit = {
            body: content_,
            method: "POST",
            headers: {
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processCompleteThreeDSecureChallenge(_response);
        });
    }

    protected processCompleteThreeDSecureChallenge(response: Response): Promise<void> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            return;
            });
        } else if (status === 400) {
            return response.text().then((_responseText) => {
            let result400: any = null;
            result400 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as ProblemDetails;
            return throwException("A server side error occurred.", status, _responseText, _headers, result400);
            });
        } else if (status === 500) {
            return response.text().then((_responseText) => {
            return throwException("A server side error occurred.", status, _responseText, _headers);
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<void>(null as any);
    }

    completeThreeDSecureFallback(flowId: string, paRes: string | null | undefined, md: string | null | undefined, mdx: string | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/umbraco/api/Opayo/payments/{flowId}/completeThreeDSecureFallback";
        if (flowId === undefined || flowId === null)
            throw new Error("The parameter 'flowId' must be defined.");
        url_ = url_.replace("{flowId}", encodeURIComponent("" + flowId));
        url_ = url_.replace(/[?&]$/, "");

        const content_ = new FormData();
        if (paRes !== null && paRes !== undefined)
            content_.append("PaRes", paRes.toString());
        if (md !== null && md !== undefined)
            content_.append("Md", md.toString());
        if (mdx !== null && mdx !== undefined)
            content_.append("Mdx", mdx.toString());

        let options_: RequestInit = {
            body: content_,
            method: "POST",
            headers: {
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processCompleteThreeDSecureFallback(_response);
        });
    }

    protected processCompleteThreeDSecureFallback(response: Response): Promise<void> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            return;
            });
        } else if (status === 400) {
            return response.text().then((_responseText) => {
            let result400: any = null;
            result400 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as ProblemDetails;
            return throwException("A server side error occurred.", status, _responseText, _headers, result400);
            });
        } else if (status === 500) {
            return response.text().then((_responseText) => {
            return throwException("A server side error occurred.", status, _responseText, _headers);
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<void>(null as any);
    }

    getMerchantSessionKey(): Promise<MerchantSessionKeyRes> {
        let url_ = this.baseUrl + "/umbraco/api/Opayo/merchantSessionKey";
        url_ = url_.replace(/[?&]$/, "");

        let options_: RequestInit = {
            method: "GET",
            headers: {
                "Accept": "application/json"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processGetMerchantSessionKey(_response);
        });
    }

    protected processGetMerchantSessionKey(response: Response): Promise<MerchantSessionKeyRes> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as MerchantSessionKeyRes;
            return result200;
            });
        } else if (status === 400) {
            return response.text().then((_responseText) => {
            let result400: any = null;
            result400 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as ProblemDetails;
            return throwException("A server side error occurred.", status, _responseText, _headers, result400);
            });
        } else if (status === 500) {
            return response.text().then((_responseText) => {
            return throwException("A server side error occurred.", status, _responseText, _headers);
            });
        } else if (status === 422) {
            return response.text().then((_responseText) => {
            let result422: any = null;
            result422 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as ProblemDetails;
            return throwException("A server side error occurred.", status, _responseText, _headers, result422);
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<MerchantSessionKeyRes>(null as any);
    }

    chargeCard(flowId: string, req: ChargeCardReq): Promise<PaymentFlowResOfOpayoPayment> {
        let url_ = this.baseUrl + "/umbraco/api/Opayo/payments/{flowId}/charge";
        if (flowId === undefined || flowId === null)
            throw new Error("The parameter 'flowId' must be defined.");
        url_ = url_.replace("{flowId}", encodeURIComponent("" + flowId));
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(req);

        let options_: RequestInit = {
            body: content_,
            method: "POST",
            headers: {
                "Content-Type": "application/json",
                "Accept": "application/json"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processChargeCard(_response);
        });
    }

    protected processChargeCard(response: Response): Promise<PaymentFlowResOfOpayoPayment> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as PaymentFlowResOfOpayoPayment;
            return result200;
            });
        } else if (status === 400) {
            return response.text().then((_responseText) => {
            let result400: any = null;
            result400 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as ProblemDetails;
            return throwException("A server side error occurred.", status, _responseText, _headers, result400);
            });
        } else if (status === 500) {
            return response.text().then((_responseText) => {
            return throwException("A server side error occurred.", status, _responseText, _headers);
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<PaymentFlowResOfOpayoPayment>(null as any);
    }

    storeCard(flowId: string, req: StoreCardReq): Promise<PaymentFlowResOfOpayoCredential> {
        let url_ = this.baseUrl + "/umbraco/api/Opayo/credentials/{flowId}/store";
        if (flowId === undefined || flowId === null)
            throw new Error("The parameter 'flowId' must be defined.");
        url_ = url_.replace("{flowId}", encodeURIComponent("" + flowId));
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(req);

        let options_: RequestInit = {
            body: content_,
            method: "POST",
            headers: {
                "Content-Type": "application/json",
                "Accept": "application/json"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processStoreCard(_response);
        });
    }

    protected processStoreCard(response: Response): Promise<PaymentFlowResOfOpayoCredential> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as PaymentFlowResOfOpayoCredential;
            return result200;
            });
        } else if (status === 400) {
            return response.text().then((_responseText) => {
            let result400: any = null;
            result400 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as ProblemDetails;
            return throwException("A server side error occurred.", status, _responseText, _headers, result400);
            });
        } else if (status === 500) {
            return response.text().then((_responseText) => {
            return throwException("A server side error occurred.", status, _responseText, _headers);
            });
        } else if (status !== 200 && status !== 204) {
            return response.text().then((_responseText) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            });
        }
        return Promise.resolve<PaymentFlowResOfOpayoCredential>(null as any);
    }
}

export interface ProblemDetails {
    type?: string | undefined;
    title?: string | undefined;
    status?: number | undefined;
    detail?: string | undefined;
    instance?: string | undefined;
}

export interface MerchantSessionKeyRes {
    key?: string | undefined;
    expiresAt?: Date;
}

export interface PaymentFlowResOfOpayoPayment {
    flowRevision?: number;
    result?: OpayoPayment | undefined;
}

export interface OpayoPayment {
    card?: CardPayment | undefined;
    paidAt?: Date | undefined;
    declinedAt?: Date | undefined;
    declinedReason?: string | undefined;
    isDeclined?: boolean;
    isPaid?: boolean;
    type?: PaymentObjectType | undefined;
    completeAt?: Date | undefined;
    errorAt?: Date | undefined;
    errorMessage?: string | undefined;
    exceptionDetails?: string | undefined;
    status?: PaymentObjectStatus | undefined;
    opayoTransactionId?: string | undefined;
    opayoStatusCode?: number | undefined;
    opayoStatusDetail?: string | undefined;
    opayoMerchantSessionKey?: string | undefined;
    opayoErrorCode?: number | undefined;
    opayoErrorMessage?: string | undefined;
    opayoBankAuthorisationCode?: string | undefined;
    opayoRetrievalReference?: number | undefined;
    returnUrl?: string | undefined;
    method?: string | undefined;
}

export interface CardPayment {
    threeDSecureRequired?: boolean;
    threeDSecureCompleted?: boolean;
    threeDSecureUrl?: string | undefined;
    challenge?: ChallengeThreeDSecure | undefined;
    fallback?: FallbackThreeDSecure | undefined;
}

export interface ChallengeThreeDSecure {
    acsTransId?: string | undefined;
    cReq?: string | undefined;
    cRes?: string | undefined;
}

export interface FallbackThreeDSecure {
    termUrl?: string | undefined;
    paReq?: string | undefined;
    paRes?: string | undefined;
}

/** One of 'credential', 'payment' */
export enum PaymentObjectType {
    Credential = "credential",
    Payment = "payment",
}

/** One of 'complete', 'error', 'inProgress' */
export enum PaymentObjectStatus {
    Complete = "complete",
    Error = "error",
    InProgress = "inProgress",
}

export interface ChargeCardReq {
    merchantSessionKey?: string | undefined;
    cardIdentifier?: string | undefined;
    value?: MoneyReq | undefined;
    browserParameters?: BrowserParametersReq | undefined;
    challengeWindowSize?: ChallengeWindowSize | undefined;
    returnUrl?: string | undefined;
}

export interface MoneyReq {
    amount?: number | undefined;
    currency?: string | undefined;
}

export interface BrowserParametersReq {
    colourDepth?: number | undefined;
    javaEnabled?: boolean | undefined;
    javaScriptEnabled?: boolean | undefined;
    screenHeight?: number | undefined;
    screenWidth?: number | undefined;
    utcOffsetMinutes?: number | undefined;
}

/** One of 'small', 'medium', 'large', 'extraLarge', 'fullScreen' */
export enum ChallengeWindowSize {
    Small = "small",
    Medium = "medium",
    Large = "large",
    ExtraLarge = "extraLarge",
    FullScreen = "fullScreen",
}

export interface PaymentFlowResOfOpayoCredential {
    flowRevision?: number;
    result?: OpayoCredential | undefined;
}

export interface OpayoCredential {
    advancePayment?: Payment | undefined;
    setupAt?: Date | undefined;
    isSetUp?: boolean;
    type?: PaymentObjectType | undefined;
    completeAt?: Date | undefined;
    errorAt?: Date | undefined;
    errorMessage?: string | undefined;
    exceptionDetails?: string | undefined;
    status?: PaymentObjectStatus | undefined;
    method?: string | undefined;
}

export interface Payment {
    completeAt?: Date | undefined;
    errorAt?: Date | undefined;
    errorMessage?: string | undefined;
    exceptionDetails?: string | undefined;
    status?: PaymentObjectStatus | undefined;
    card?: CardPayment | undefined;
    paidAt?: Date | undefined;
    declinedAt?: Date | undefined;
    declinedReason?: string | undefined;
    isDeclined?: boolean;
    isPaid?: boolean;
    type?: PaymentObjectType | undefined;
}

export interface StoreCardReq {
    advancePayment?: ChargeCardReq | undefined;
}

export class ApiException extends Error {
    message: string;
    status: number;
    response: string;
    headers: { [key: string]: any; };
    result: any;

    constructor(message: string, status: number, response: string, headers: { [key: string]: any; }, result: any) {
        super();

        this.message = message;
        this.status = status;
        this.response = response;
        this.headers = headers;
        this.result = result;
    }

    protected isApiException = true;

    static isApiException(obj: any): obj is ApiException {
        return obj.isApiException === true;
    }
}

function throwException(message: string, status: number, response: string, headers: { [key: string]: any; }, result?: any): any {
    if (result !== null && result !== undefined)
        throw result;
    else
        throw new ApiException(message, status, response, headers, null);
}
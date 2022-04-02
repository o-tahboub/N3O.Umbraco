export declare class BamboraClient {
    private http;
    private baseUrl;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined;
    constructor(baseUrl?: string, http?: {
        fetch(url: RequestInfo, init?: RequestInit): Promise<Response>;
    });
    completePaymentThreeDSecureChallenge(flowId: string, req: ThreeDSecureChallengeReq): Promise<void>;
    protected processCompletePaymentThreeDSecureChallenge(response: Response): Promise<void>;
    chargeCard(flowId: string, req: ChargeCardReq): Promise<PaymentFlowResOfBamboraPayment>;
    protected processChargeCard(response: Response): Promise<PaymentFlowResOfBamboraPayment>;
    storeCard(flowId: string, req: StoreCardReq): Promise<PaymentFlowResOfBamboraPayment>;
    protected processStoreCard(response: Response): Promise<PaymentFlowResOfBamboraPayment>;
}
export interface ProblemDetails {
    type?: string | undefined;
    title?: string | undefined;
    status?: number | undefined;
    detail?: string | undefined;
    instance?: string | undefined;
}
export interface ThreeDSecureChallengeReq {
    cRes?: string | undefined;
    threeDSessionData?: string | undefined;
}
export interface PaymentFlowResOfBamboraPayment {
    flowRevision?: number;
    result?: BamboraPayment | undefined;
}
export interface BamboraPayment {
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
    bamboraErrorCode?: number | undefined;
    bamboraErrorMessage?: string | undefined;
    bamboraPaymentId?: string | undefined;
    bamboraStatusCode?: number | undefined;
    bamboraStatusDetail?: string | undefined;
    bamboraToken?: string | undefined;
    returnUrl?: string | undefined;
    method?: string | undefined;
}
export interface CardPayment {
    threeDSecureRequired?: boolean;
    threeDSecureCompleted?: boolean;
    threeDSecureChallengeUrl?: string | undefined;
    threeDSecureAcsTransId?: string | undefined;
    threeDSecureCReq?: string | undefined;
    threeDSecureCRes?: string | undefined;
}
/** One of 'credential', 'payment' */
export declare enum PaymentObjectType {
    Credential = "credential",
    Payment = "payment"
}
/** One of 'complete', 'error', 'inProgress' */
export declare enum PaymentObjectStatus {
    Complete = "complete",
    Error = "error",
    InProgress = "inProgress"
}
export interface ChargeCardReq {
    token?: string | undefined;
    value?: MoneyReq | undefined;
    returnUrl?: string | undefined;
    browserParameters?: BrowserParametersReq | undefined;
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
export interface StoreCardReq {
    token?: string | undefined;
    returnUrl?: string | undefined;
    browserParameters?: BrowserParametersReq | undefined;
}
export declare class ApiException extends Error {
    message: string;
    status: number;
    response: string;
    headers: {
        [key: string]: any;
    };
    result: any;
    constructor(message: string, status: number, response: string, headers: {
        [key: string]: any;
    }, result: any);
    protected isApiException: boolean;
    static isApiException(obj: any): obj is ApiException;
}
//# sourceMappingURL=index.d.ts.map
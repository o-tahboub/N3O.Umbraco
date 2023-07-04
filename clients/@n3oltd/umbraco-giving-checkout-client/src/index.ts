//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.18.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v10.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

/* tslint:disable */
/* eslint-disable */
// ReSharper disable InconsistentNaming

export class CheckoutClient {
    private http: { fetch(url: RequestInfo, init?: RequestInit): Promise<Response> };
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(baseUrl?: string, http?: { fetch(url: RequestInfo, init?: RequestInit): Promise<Response> }) {
        this.http = http ? http : window as any;
        this.baseUrl = baseUrl !== undefined && baseUrl !== null ? baseUrl : "https://localhost:6001";
    }

    getCurrentCheckout(): Promise<CheckoutRes> {
        let url_ = this.baseUrl + "/umbraco/api/Checkout/current";
        url_ = url_.replace(/[?&]$/, "");

        let options_: RequestInit = {
            method: "GET",
            headers: {
                "Accept": "application/json"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processGetCurrentCheckout(_response);
        });
    }

    protected processGetCurrentCheckout(response: Response): Promise<CheckoutRes> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as CheckoutRes;
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
        return Promise.resolve<CheckoutRes>(null as any);
    }

    getLookupCheckoutStages(): Promise<NamedLookupRes[]> {
        let url_ = this.baseUrl + "/umbraco/api/Checkout/lookups/checkoutStages";
        url_ = url_.replace(/[?&]$/, "");

        let options_: RequestInit = {
            method: "GET",
            headers: {
                "Accept": "application/json"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processGetLookupCheckoutStages(_response);
        });
    }

    protected processGetLookupCheckoutStages(response: Response): Promise<NamedLookupRes[]> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as NamedLookupRes[];
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
        return Promise.resolve<NamedLookupRes[]>(null as any);
    }

    getRegularGivingFrequencies(): Promise<NamedLookupRes[]> {
        let url_ = this.baseUrl + "/umbraco/api/Checkout/lookups/regularGivingFrequencies";
        url_ = url_.replace(/[?&]$/, "");

        let options_: RequestInit = {
            method: "GET",
            headers: {
                "Accept": "application/json"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processGetRegularGivingFrequencies(_response);
        });
    }

    protected processGetRegularGivingFrequencies(response: Response): Promise<NamedLookupRes[]> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as NamedLookupRes[];
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
        return Promise.resolve<NamedLookupRes[]>(null as any);
    }

    updateAccount(checkoutRevisionId: string, req: AccountReq): Promise<CheckoutRes> {
        let url_ = this.baseUrl + "/umbraco/api/Checkout/{checkoutRevisionId}/account";
        if (checkoutRevisionId === undefined || checkoutRevisionId === null)
            throw new Error("The parameter 'checkoutRevisionId' must be defined.");
        url_ = url_.replace("{checkoutRevisionId}", encodeURIComponent("" + checkoutRevisionId));
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
            return this.processUpdateAccount(_response);
        });
    }

    protected processUpdateAccount(response: Response): Promise<CheckoutRes> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as CheckoutRes;
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
        return Promise.resolve<CheckoutRes>(null as any);
    }

    updateRegularGivingOptions(checkoutRevisionId: string, req: RegularGivingOptionsReq): Promise<CheckoutRes> {
        let url_ = this.baseUrl + "/umbraco/api/Checkout/{checkoutRevisionId}/regularGiving/options";
        if (checkoutRevisionId === undefined || checkoutRevisionId === null)
            throw new Error("The parameter 'checkoutRevisionId' must be defined.");
        url_ = url_.replace("{checkoutRevisionId}", encodeURIComponent("" + checkoutRevisionId));
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
            return this.processUpdateRegularGivingOptions(_response);
        });
    }

    protected processUpdateRegularGivingOptions(response: Response): Promise<CheckoutRes> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as CheckoutRes;
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
        return Promise.resolve<CheckoutRes>(null as any);
    }

    getAllLookups(criteria: LookupsCriteria): Promise<CheckoutLookupsRes> {
        let url_ = this.baseUrl + "/umbraco/api/Checkout/lookups/all";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(criteria);

        let options_: RequestInit = {
            body: content_,
            method: "POST",
            headers: {
                "Content-Type": "application/json",
                "Accept": "application/json"
            }
        };

        return this.http.fetch(url_, options_).then((_response: Response) => {
            return this.processGetAllLookups(_response);
        });
    }

    protected processGetAllLookups(response: Response): Promise<CheckoutLookupsRes> {
        const status = response.status;
        let _headers: any = {}; if (response.headers && response.headers.forEach) { response.headers.forEach((v: any, k: any) => _headers[k] = v); };
        if (status === 200) {
            return response.text().then((_responseText) => {
            let result200: any = null;
            result200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver) as CheckoutLookupsRes;
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
        return Promise.resolve<CheckoutLookupsRes>(null as any);
    }
}

export interface CheckoutRes {
    /** A well formed guid */
    id?: string | undefined;
    /** A well formed revision ID string */
    revisionId?: string | undefined;
    reference?: Reference | undefined;
    currency?: string | undefined;
    progress?: CheckoutProgressRes | undefined;
    account?: AccountRes | undefined;
    donation?: DonationCheckoutRes | undefined;
    regularGiving?: RegularGivingCheckoutRes | undefined;
    isComplete?: boolean;
}

export interface Reference {
    type?: string | undefined;
    number?: number;
    text?: string | undefined;
}

export interface CheckoutProgressRes {
    currentStage?: CheckoutStage | undefined;
    requiredStages?: CheckoutStage[] | undefined;
    remainingStages?: CheckoutStage[] | undefined;
}

/** One of 'account', 'donation', 'regularGiving' */
export enum CheckoutStage {
    Account = "account",
    Donation = "donation",
    RegularGiving = "regularGiving",
}

export interface AccountRes {
    name?: NameRes | undefined;
    address?: AddressRes | undefined;
    email?: EmailRes | undefined;
    telephone?: TelephoneRes | undefined;
    consent?: ConsentRes | undefined;
    taxStatus?: TaxStatus | undefined;
}

export interface NameRes {
    title?: string | undefined;
    firstName?: string | undefined;
    lastName?: string | undefined;
}

export interface AddressRes {
    line1?: string | undefined;
    line2?: string | undefined;
    line3?: string | undefined;
    locality?: string | undefined;
    administrativeArea?: string | undefined;
    postalCode?: string | undefined;
    country?: string | undefined;
}

export interface EmailRes {
    address?: string | undefined;
}

export interface TelephoneRes {
    country?: string | undefined;
    number?: string | undefined;
}

export interface ConsentRes {
    choices?: ConsentChoiceRes[] | undefined;
}

export interface ConsentChoiceRes {
    channel?: ConsentChannel | undefined;
    category?: string | undefined;
    response?: ConsentResponse | undefined;
}

/** One of 'email', 'sms', 'post', 'telephone' */
export enum ConsentChannel {
    Email = "email",
    Sms = "sms",
    Post = "post",
    Telephone = "telephone",
}

/** One of 'noResponse', 'optIn', 'optOut' */
export enum ConsentResponse {
    NoResponse = "noResponse",
    OptIn = "optIn",
    OptOut = "optOut",
}

/** One of 'payer', 'nonPayer', 'notSpecified' */
export enum TaxStatus {
    Payer = "payer",
    NonPayer = "nonPayer",
    NotSpecified = "notSpecified",
}

export interface DonationCheckoutRes {
    allocations?: AllocationRes[] | undefined;
    payment?: PaymentRes | undefined;
    total?: MoneyRes | undefined;
    isComplete?: boolean;
    isRequired?: boolean;
}

export interface AllocationRes {
    type?: AllocationType | undefined;
    value?: MoneyRes | undefined;
    fundDimensions?: FundDimensionValuesRes | undefined;
    feedback?: FeedbackAllocationRes | undefined;
    fund?: FundAllocationRes | undefined;
    sponsorship?: SponsorshipAllocationRes | undefined;
    upsell?: boolean;
}

/** One of 'feedback', 'fund', 'sponsorship' */
export enum AllocationType {
    Feedback = "feedback",
    Fund = "fund",
    Sponsorship = "sponsorship",
}

export interface MoneyRes {
    amount?: number;
    currency?: string | undefined;
    text?: string | undefined;
}

export interface FundDimensionValuesRes {
    dimension1?: string | undefined;
    dimension2?: string | undefined;
    dimension3?: string | undefined;
    dimension4?: string | undefined;
}

export interface FeedbackAllocationRes {
    scheme?: string | undefined;
    customFields?: FeedbackCustomFieldRes[] | undefined;
}

/** One of 'donation', 'regularGiving' */
export enum GivingType {
    Donation = "donation",
    RegularGiving = "regularGiving",
}

export interface FeedbackCustomFieldDefinitionElement {
    content?: IPublishedElement | undefined;
    type?: FeedbackCustomFieldType | undefined;
    name?: string | undefined;
    required?: boolean;
    textMaxLength?: number | undefined;
    alias?: string | undefined;
}

export interface IPublishedElement {
    contentType?: IPublishedContentType;
    key?: string;
    properties?: IPublishedProperty[];
}

export interface IPublishedContentType {
    key?: string;
    id?: number;
    alias?: string;
    itemType?: PublishedItemType;
    compositionAliases?: string[];
    variations?: ContentVariation;
    isElement?: boolean;
    propertyTypes?: IPublishedPropertyType[];
}

export enum PublishedItemType {
    Unknown = 0,
    Element = 1,
    Content = 2,
    Media = 3,
    Member = 4,
}

export enum ContentVariation {
    Nothing = 0,
    Culture = 1,
    Segment = 2,
    CultureAndSegment = 3,
}

export interface IPublishedPropertyType {
    contentType?: IPublishedContentType | undefined;
    dataType?: PublishedDataType;
    alias?: string;
    editorAlias?: string;
    isUserProperty?: boolean;
    variations?: ContentVariation;
    cacheLevel?: PropertyCacheLevel;
    modelClrType?: string;
    clrType?: string | undefined;
}

export interface PublishedDataType {
    id?: number;
    editorAlias?: string;
    configuration?: any | undefined;
}

export enum PropertyCacheLevel {
    Unknown = 0,
    Element = 1,
    Elements = 2,
    Snapshot = 3,
    None = 4,
}

export interface IPublishedProperty {
    propertyType?: IPublishedPropertyType;
    alias?: string;
}

/** One of 'bool', 'date', 'text' */
export enum FeedbackCustomFieldType {
    Bool = "bool",
    Date = "date",
    Text = "text",
}

export interface PriceContent {
    amount?: number;
    locked?: boolean;
}

export interface PricingRuleElement {
    content?: IPublishedElement | undefined;
    amount?: number;
    locked?: boolean;
    dimension1?: string | undefined;
    dimension2?: string | undefined;
    dimension3?: string | undefined;
    dimension4?: string | undefined;
}

export interface FeedbackCustomFieldRes {
    type?: FeedbackCustomFieldType | undefined;
    alias?: string | undefined;
    name?: string | undefined;
    bool?: boolean | undefined;
    date?: Date | undefined;
    text?: string | undefined;
}

export interface FundAllocationRes {
    donationItem?: string | undefined;
}

export interface SponsorshipAllocationRes {
    beneficiary?: string | undefined;
    scheme?: string | undefined;
    duration?: SponsorshipDuration | undefined;
    components?: SponsorshipComponentAllocationRes[] | undefined;
}

/** One of '_6', '_12', '_18', '_24', '_36', '_48', '_60' */
export enum SponsorshipDuration {
    _6 = "_6",
    _12 = "_12",
    _18 = "_18",
    _24 = "_24",
    _36 = "_36",
    _48 = "_48",
    _60 = "_60",
}

export interface SponsorshipComponentAllocationRes {
    component?: string | undefined;
    value?: MoneyRes | undefined;
}

export interface PaymentRes {
    type?: PaymentObjectType | undefined;
    method?: string | undefined;
    status?: PaymentObjectStatus | undefined;
    errorMessage?: string | undefined;
    hasError?: boolean;
    isComplete?: boolean;
    isInProgress?: boolean;
    card?: CardPaymentRes | undefined;
    declinedReason?: string | undefined;
    isDeclined?: boolean;
    isPaid?: boolean;
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

export interface CardPaymentRes {
    threeDSecureRequired?: boolean;
    threeDSecureCompleted?: boolean;
    threeDSecureV1?: ThreeDSecureV1 | undefined;
    threeDSecureV2?: ThreeDSecureV2 | undefined;
}

export interface ThreeDSecureV1 {
    acsUrl?: string | undefined;
    md?: string | undefined;
    paReq?: string | undefined;
    paRes?: string | undefined;
}

export interface ThreeDSecureV2 {
    acsUrl?: string | undefined;
    acsTransId?: string | undefined;
    sessionData?: string | undefined;
    cReq?: string | undefined;
    cRes?: string | undefined;
    html?: string | undefined;
}

export interface RegularGivingCheckoutRes {
    allocations?: AllocationRes[] | undefined;
    credential?: CredentialRes | undefined;
    options?: RegularGivingOptionsRes | undefined;
    total?: MoneyRes | undefined;
    isComplete?: boolean;
    isRequired?: boolean;
}

export interface CredentialRes {
    type?: PaymentObjectType | undefined;
    method?: string | undefined;
    status?: PaymentObjectStatus | undefined;
    errorMessage?: string | undefined;
    hasError?: boolean;
    isComplete?: boolean;
    isInProgress?: boolean;
    advancePayment?: PaymentRes | undefined;
    setupAt?: Date | undefined;
    isSetUp?: boolean;
}

export interface RegularGivingOptionsRes {
    preferredCollectionDay?: string | undefined;
    frequency?: RegularGivingFrequency | undefined;
    firstCollectionDate?: Date | undefined;
}

/** One of 'annually', 'monthly', 'quarterly' */
export enum RegularGivingFrequency {
    Annually = "annually",
    Monthly = "monthly",
    Quarterly = "quarterly",
}

export interface ProblemDetails {
    type?: string | undefined;
    title?: string | undefined;
    status?: number | undefined;
    detail?: string | undefined;
    instance?: string | undefined;

    [key: string]: any;
}

export interface NamedLookupRes {
    id?: string | undefined;
    name?: string | undefined;
}

export interface AccountReq {
    name?: NameReq | undefined;
    address?: AddressReq | undefined;
    email?: EmailReq | undefined;
    telephone?: TelephoneReq | undefined;
    consent?: ConsentReq | undefined;
    taxStatus?: TaxStatus | undefined;
}

export interface NameReq {
    title?: string | undefined;
    firstName?: string | undefined;
    lastName?: string | undefined;
}

export interface AddressReq {
    line1?: string | undefined;
    line2?: string | undefined;
    line3?: string | undefined;
    locality?: string | undefined;
    administrativeArea?: string | undefined;
    postalCode?: string | undefined;
    country?: string | undefined;
}

export interface EmailReq {
    address?: string | undefined;
}

export interface TelephoneReq {
    country?: string | undefined;
    number?: string | undefined;
}

export interface ConsentReq {
    choices?: ConsentChoiceReq[] | undefined;
}

export interface ConsentChoiceReq {
    channel?: ConsentChannel | undefined;
    category?: string | undefined;
    response?: ConsentResponse | undefined;
}

export interface RegularGivingOptionsReq {
    preferredCollectionDay?: string | undefined;
    frequency?: RegularGivingFrequency | undefined;
    firstCollectionDate?: Date | undefined;
}

export interface CheckoutLookupsRes {
    checkoutStages?: NamedLookupRes[] | undefined;
    regularGivingFrequencies?: NamedLookupRes[] | undefined;
}

export interface LookupsCriteria {
    types?: string[] | undefined;
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
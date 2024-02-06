//
//  Plugin.h
//  ios
//
//  Created by Po Keum Cho on 2/6/24.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface Plugin : NSObject

typedef void (^UnitCallback)(void);
typedef void (^ErrorCallback)(NSError *error);

+ (void)testFuncWithDelay:(int)delayMillis
                onSuccess:(UnitCallback)onSuccess
                onFailure:(ErrorCallback)onFailure;

@end

NS_ASSUME_NONNULL_END

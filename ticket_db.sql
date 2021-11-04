/*
 Navicat MySQL Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 80019
 Source Host           : localhost:3306
 Source Schema         : ticket_db

 Target Server Type    : MySQL
 Target Server Version : 80019
 File Encoding         : 65001

 Date: 25/05/2020 10:37:08
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for admininfo
-- ----------------------------
DROP TABLE IF EXISTS `admininfo`;
CREATE TABLE `admininfo`  (
  `AdminID` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `AdminPassword` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`AdminID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of admininfo
-- ----------------------------
INSERT INTO `admininfo` VALUES ('1', '1');
INSERT INTO `admininfo` VALUES ('Admin', '123456');
INSERT INTO `admininfo` VALUES ('Alisalin', 'aaaa');
INSERT INTO `admininfo` VALUES ('郑佶', '666');

-- ----------------------------
-- Table structure for routeinfo
-- ----------------------------
DROP TABLE IF EXISTS `routeinfo`;
CREATE TABLE `routeinfo`  (
  `RouteID` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '路线ID',
  `RouteStart` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '始发站',
  `RouteEnd` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '终点站',
  `RoutePay` float(20, 0) NULL DEFAULT NULL COMMENT '票价,只由路线决定',
  PRIMARY KEY (`RouteID`) USING BTREE,
  INDEX `startFor`(`RouteStart`) USING BTREE,
  INDEX `endFor`(`RouteEnd`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of routeinfo
-- ----------------------------
INSERT INTO `routeinfo` VALUES ('1', '北京站', '天津站', 500);
INSERT INTO `routeinfo` VALUES ('2', '北京站', '河北站', 1000);
INSERT INTO `routeinfo` VALUES ('3', '天津站', '河北站', 500);
INSERT INTO `routeinfo` VALUES ('4', '河南站', '山东站', 500);
INSERT INTO `routeinfo` VALUES ('5', '江苏站', '新疆站', 500);
INSERT INTO `routeinfo` VALUES ('6', '天津站', '河南站', 1000);
INSERT INTO `routeinfo` VALUES ('7', '北京站', '河南站', 1500);
INSERT INTO `routeinfo` VALUES ('8', '新疆站', '湖南站', 500);
INSERT INTO `routeinfo` VALUES ('9', '河南站', '新疆站', 2000);

-- ----------------------------
-- Table structure for scheduleinfo
-- ----------------------------
DROP TABLE IF EXISTS `scheduleinfo`;
CREATE TABLE `scheduleinfo`  (
  `ScheduleID` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '时间段ID',
  `ScheduleStart` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '始发时间(整点,24小时制)',
  `ScheduleEnd` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL COMMENT '到站时间(整点,24小时制)',
  PRIMARY KEY (`ScheduleID`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of scheduleinfo
-- ----------------------------
INSERT INTO `scheduleinfo` VALUES ('1', '2020-6-1 3:00', '2020-6-1 4:00');
INSERT INTO `scheduleinfo` VALUES ('10', '2020-6-1 14:00', '2020-6-1 16:00');
INSERT INTO `scheduleinfo` VALUES ('11', '2020-6-1 14:00', '2020-6-1 17:00');
INSERT INTO `scheduleinfo` VALUES ('12', '2020-6-1 14:00', '2020-6-1 18:00');
INSERT INTO `scheduleinfo` VALUES ('13', '2020-6-1 15:00', '2020-6-1 17:00');
INSERT INTO `scheduleinfo` VALUES ('2', '2020-6-1 5:00', '2020-6-1 7:00');
INSERT INTO `scheduleinfo` VALUES ('3', '2020-6-1 5:00', '2020-6-1 8:00');
INSERT INTO `scheduleinfo` VALUES ('4', '2020-6-1 8:00', '2020-6-1 9:00');
INSERT INTO `scheduleinfo` VALUES ('5', '2020-6-1 9:00', '2020-6-1 10:00');
INSERT INTO `scheduleinfo` VALUES ('6', '2020-6-1 10:00', '2020-6-1 12:00');
INSERT INTO `scheduleinfo` VALUES ('7', '2020-6-1 9:00', '2020-6-1 12:00');
INSERT INTO `scheduleinfo` VALUES ('8', '2020-6-1 13:00', '2020-6-1 15:00');
INSERT INTO `scheduleinfo` VALUES ('9', '2020-6-1 14:00', '2020-6-1 15:00');

-- ----------------------------
-- Table structure for ticketinfo
-- ----------------------------
DROP TABLE IF EXISTS `ticketinfo`;
CREATE TABLE `ticketinfo`  (
  `TicketID` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TicketRouteID` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `TicketScheduleID` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `TicketBuyer` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`TicketID`) USING BTREE,
  INDEX `RouteFor`(`TicketRouteID`) USING BTREE,
  INDEX `ScheduleFor`(`TicketScheduleID`) USING BTREE,
  INDEX `NameFor`(`TicketBuyer`) USING BTREE,
  CONSTRAINT `NameFor` FOREIGN KEY (`TicketBuyer`) REFERENCES `userinfo` (`userName`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `RouteFor` FOREIGN KEY (`TicketRouteID`) REFERENCES `routeinfo` (`RouteID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `ScheduleFor` FOREIGN KEY (`TicketScheduleID`) REFERENCES `scheduleinfo` (`ScheduleID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of ticketinfo
-- ----------------------------
INSERT INTO `ticketinfo` VALUES ('1', '6', '1', '肖军');
INSERT INTO `ticketinfo` VALUES ('272', '1', '7', '李明');
INSERT INTO `ticketinfo` VALUES ('3', '1', '4', '李明');
INSERT INTO `ticketinfo` VALUES ('8', '2', '7', '李刚');
INSERT INTO `ticketinfo` VALUES ('9', '1', '7', '王八');
INSERT INTO `ticketinfo` VALUES ('900', '1', '5', '王大锤');

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS `userinfo`;
CREATE TABLE `userinfo`  (
  `userName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '用户名',
  `userIsVIP` bit(1) NULL DEFAULT b'0' COMMENT '用户是否为VIP,1为是,只有VIP能退票',
  PRIMARY KEY (`userName`) USING BTREE,
  INDEX `userName`(`userName`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of userinfo
-- ----------------------------
INSERT INTO `userinfo` VALUES ('刘军', b'0');
INSERT INTO `userinfo` VALUES ('李刚', b'1');
INSERT INTO `userinfo` VALUES ('李明', b'0');
INSERT INTO `userinfo` VALUES ('李春', b'0');
INSERT INTO `userinfo` VALUES ('王八', b'0');
INSERT INTO `userinfo` VALUES ('王大锤', b'0');
INSERT INTO `userinfo` VALUES ('肖军', b'0');
INSERT INTO `userinfo` VALUES ('陈真', b'1');

-- ----------------------------
-- View structure for ticketallinfo
-- ----------------------------
DROP VIEW IF EXISTS `ticketallinfo`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `ticketallinfo` AS select `ticketinfo`.`TicketBuyer` AS `ticketbuyer`,`routeinfo`.`RouteStart` AS `routestart`,`routeinfo`.`RouteEnd` AS `routeend`,`scheduleinfo`.`ScheduleStart` AS `schedulestart`,`scheduleinfo`.`ScheduleEnd` AS `scheduleend` from ((`routeinfo` join `scheduleinfo`) join `ticketinfo`) where ((`routeinfo`.`RouteID` = `ticketinfo`.`TicketRouteID`) and (`scheduleinfo`.`ScheduleID` = `ticketinfo`.`TicketScheduleID`) and (`ticketinfo`.`TicketID` = '900'));

-- ----------------------------
-- Procedure structure for changeinfo
-- ----------------------------
DROP PROCEDURE IF EXISTS `changeinfo`;
delimiter ;;
CREATE PROCEDURE `changeinfo`(in theticketid varchar(20),
in newscheduleid varchar(20),
inout alert varchar(20))
begin
declare a varchar(20);
set alert= '给出新值,更新成功';
set a=(select ticketscheduleid from ticketinfo where ticketid=theticketid);
if a>newscheduleid or a<newscheduleid
then
update ticketinfo set ticketscheduleid=newscheduleid where ticketid=theticketid;
else
set alert='未给出新值,更新失败';
end if;
end
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
